import { AbstractControl, ValidationErrors } from "@angular/forms";

export function namecheck(control:AbstractControl):ValidationErrors | null
{
    let v=+control.value.length
    if(isNaN(v))
    {
        return {'namecheck':true,'requiredValue':5}
    }
    if((v)<=5)
    {
        return {'namecheck':true,'requiredValue':5}
    }
    return null
}