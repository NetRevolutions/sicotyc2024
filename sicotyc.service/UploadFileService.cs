using AutoMapper;
using Microsoft.AspNetCore.Identity;
using sicotyc.contracts;
using sicotyc.entities.Models;
using sicotyc.service.contracts;

namespace sicotyc.service
{
    public class UploadFileService : IUploadFileService
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IAuthenticationManager _authManager;
        private readonly IRepositoryManager _respository;

        public UploadFileService(ILoggerManager logger, IMapper mapper,
            UserManager<User> userManager, IAuthenticationManager authManager, IRepositoryManager repository)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _authManager = authManager;
            _respository = repository;
        }

        public async Task<bool> UpdateImageAsync(string type, Guid id, string rootPath, string fileName)
        {
            string oldPath = String.Empty;
            switch (type.ToUpper())
            {
                case "USERS":
                    var userDB = await _userManager.FindByIdAsync(id.ToString());
                    if (userDB == null)
                    {
                        _logger.LogError($"Usuario con id {id} no existe en la BD");
                        return false;
                    }

                    oldPath = Path.Combine(rootPath, "Uploads", type!, userDB.Img == null ? string.Empty : userDB.Img);

                    this.DeleteImage(oldPath);

                    userDB.Img = fileName;
                    await _userManager.UpdateAsync(userDB);
                    return true;

                //break;
                case "UNITTRANSPORTS":
                    var unitTransportDb = await _respository.UnitTransport.GetUnitTransportByIdAsync(id, trackChanges: true);
                    if (unitTransportDb == null)
                    {
                        _logger.LogError($"Unidad de Transporte con id {id} no existe en la BD");
                        return false;
                    }

                    oldPath = Path.Combine(rootPath, "Uploads", type!, unitTransportDb.Img == null ? string.Empty : unitTransportDb.Img);

                    this.DeleteImage(oldPath);

                    unitTransportDb.Img = fileName;
                    await _respository.SaveAsync();
                    return true;
                //break;
                case "DRIVERS":
                    var driverDB = await _respository.Driver.GetDriverByIdAsync(id, trackChanges: true);
                    if (driverDB == null)
                    {
                        _logger.LogError($"Driver con id {id} no existe en la BD");
                        return false;
                    }

                    oldPath = Path.Combine(rootPath, "Uploads", type!, driverDB.Img == null ? string.Empty : driverDB.Img);

                    this.DeleteImage(oldPath);

                    driverDB.Img = fileName;
                    await _respository.SaveAsync();
                    return true;

                default:
                    return false;
            }
        }

        public async Task<bool> DeleteImageAsync(string type, string rootPath, string fileName)
        {
            string oldPath = Path.Combine(rootPath, "Uploads", type!, fileName);
            this.DeleteImage(oldPath);
            await Task.Delay(100);
            return true;
        }

        private void DeleteImage(string oldPath)
        {
            if (File.Exists(oldPath))
            {
                // Borrar la imagen anterior
                File.Delete(oldPath);
            }
        }
    }
}
