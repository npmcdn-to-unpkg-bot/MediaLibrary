"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var ContactFormComponent = (function () {
    function ContactFormComponent() {
    }
    ContactFormComponent.prototype.log = function (x) {
        console.log(x);
    };
    ContactFormComponent = __decorate([
        core_1.Component({
            selector: 'contact-form',
            template: "\n<form>\n    <div class=\"form-group\">\n        <label for=\"firstName\">First name</label>\n        <input ngControl=\"firstName\" #firstName=\"ngForm\" (change)=\"log(firstName)\" id=\"firstName\" type=\"text\" class=\"form-control\">\n    </div>\n    <div class=\"form-group\">\n        <label for=\"comment\">Comment</label>\n        <textarea ngControl=\"comment\" id=\"comment\" cols=\"30\" rows=\"10\" class=\"form-control\"></textarea>\n    </div>\n    <button class=\"btn btn-primary\" type=\"submit\">Submit</button>\n</form>"
        }), 
        __metadata('design:paramtypes', [])
    ], ContactFormComponent);
    return ContactFormComponent;
}());
exports.ContactFormComponent = ContactFormComponent;
//# sourceMappingURL=contact-form.component.js.map