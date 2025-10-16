import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-articles',
  imports: [CommonModule],
  templateUrl: './articles.component.html',
  styleUrl: './articles.component.css'
})
export class ArticlesComponent {
  posts = [
    {
      title: 'Welcome to My Blog',
      summary: 'Kickstarting my journey into writing and sharing ideas.',
      image: 'assets/blog1.jpg'
    },
    {
      title: 'Angular Tips & Tricks',
      summary: 'Useful techniques to improve your Angular development.',
      image: 'assets/blog2.jpg'
    },
    {
      title: 'Designing with Bootstrap',
      summary: 'How to make your site look great with minimal effort.',
      image: 'assets/blog3.jpg'
    }
  ];
}

