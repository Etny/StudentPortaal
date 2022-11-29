import { NgModule } from '@angular/core';

import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from '@angular/material/divider'; 

const MaterialModules = [
    MatCardModule,
    MatButtonModule,
    MatDividerModule,
]

@NgModule(
    {
        exports: [MaterialModules],
        imports: [MaterialModules]
    }
)
export class MaterialModule { }