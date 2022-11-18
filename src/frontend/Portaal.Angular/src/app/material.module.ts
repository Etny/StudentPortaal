import { NgModule } from '@angular/core';

import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';

const MaterialModules = [
    MatCardModule,
    MatButtonModule,
]

@NgModule(
    {
        exports: [MaterialModules],
        imports: [MaterialModules]
    }
)
export class MaterialModule { }