import { AbstractControl } from "@angular/forms";

export function ValidateUrl(control:AbstractControl)
{
    console.log(676879)
    if(!control.value.startsWith('https:')|| !control.value.include('.com'))
    {
        return {invalidUrl:true}
    }
    return null;
}