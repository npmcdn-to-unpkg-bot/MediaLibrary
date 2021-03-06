﻿import {Component} from '@angular/core';

@Component({
    selector: 'contact-form',
    template: `
<form>
    <div class="form-group">
        <label for="firstName">First name</label>
        <input ngControl="firstName" #firstName="ngForm" (change)="log(firstName)" id="firstName" type="text" class="form-control">
    </div>
    <div class="form-group">
        <label for="comment">Comment</label>
        <textarea ngControl="comment" id="comment" cols="30" rows="10" class="form-control"></textarea>
    </div>
    <button class="btn btn-primary" type="submit">Submit</button>
</form>`
})

export class ContactFormComponent {
    log(x) {
        console.log(x);
    }
}