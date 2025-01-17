import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-text-truncate',
  templateUrl: './text-truncate.component.html',
  styleUrls: ['./text-truncate.component.css']
})
export class TextTruncateComponent {
  @Input() text: string = ''; // Recibe el texto como entrada
  @Input() maxLength: number = 20; // Texto maximo para empezar a acortar

  get truncatedText(): string {
    return this.text.length > this.maxLength
      ? this.text.substring(0, this.maxLength) + '...'
      : this.text;
  };

  
}
