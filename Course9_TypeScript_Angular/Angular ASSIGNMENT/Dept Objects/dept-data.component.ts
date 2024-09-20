import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-dept-data',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './dept-data.component.html',
  styleUrl: './dept-data.component.css'
})
export class DeptDataComponent {
  public deptsArray:any[] = [
    {deptno : 10, dname : "Accounts", loc : "Hyderabad"},
    {deptno : 20, dname : "Sales", loc : "Pune"},
    {deptno : 30, dname : "Operations", loc : "Mumbai"},
    {deptno : 40, dname : "Marketing", loc : "Chennai"},
    {deptno : 10, dname : "Accounts", loc : "Hyderabad"},
    {deptno : 20, dname : "Sales", loc : "Pune"},
    {deptno : 30, dname : "Operations", loc : "Mumbai"},
    {deptno : 40, dname : "Marketing", loc : "Chennai"},
    {deptno : 50, dname : "Marketing", loc : "Chennai"}
  ];
}
