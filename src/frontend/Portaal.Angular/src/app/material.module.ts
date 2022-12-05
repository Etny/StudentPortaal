import { NgModule } from '@angular/core';

import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from '@angular/material/divider'; 
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip'; 

const MaterialModules = [
    MatCardModule,
    MatButtonModule,
    MatDividerModule,
    MatInputModule,
    MatFormFieldModule,
    MatIconModule,
    MatTooltipModule
]

@NgModule(
    {
        exports: [MaterialModules],
        imports: [MaterialModules]
    }
)
export class MaterialModule { }