import { EntityDialog } from '@serenity-is/corelib';
import { PersonForm, PersonRow, PersonService } from '../../ServerTypes/MovieDB';
import "./PersonDialog.css"; // import the css

export class PersonDialog extends EntityDialog<PersonRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("MovieDatabase.MovieDB.");

    protected override getFormKey() { return PersonForm.formKey; }
    protected override getRowDefinition() { return PersonRow; }
    protected override getService() { return PersonService.baseUrl; }

    protected form = new PersonForm(this.idPrefix);

    protected override afterLoadEntity() {
        super.afterLoadEntity();

        this.form.MoviesGrid.personId = this.entityId;
    }
}