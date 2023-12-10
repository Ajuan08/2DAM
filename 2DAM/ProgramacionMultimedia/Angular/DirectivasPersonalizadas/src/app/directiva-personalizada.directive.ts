import { Directive, ElementRef, HostBinding, HostListener, Input, Renderer2 } from '@angular/core';

@Directive({
  selector: '[DirectivaPersonalizada]'
})
export class DirectivaPersonalizadaDirective {

  @HostBinding('style.border') private border!: string;
  @Input() borderColor!: string;
  @Input() linkText!: string;

  private originalText!: string;

  constructor(private el: ElementRef, private renderer: Renderer2) {  }

  @HostListener('mouseEnter') onMouseEnter() {
    this.originalText = this.el.nativeElement.innerText;

    this.renderer.setProperty(this.el.nativeElement, 'innerText', this.linkText.toUpperCase());
    this.border = `3px solid ${this.borderColor}`;
  }

  @HostListener('mouseLeave') onMouseLeave() {
    
    this.renderer.setProperty(this.el.nativeElement, 'innerText', this.originalText);
    this.border = 'none';
  }

}
