import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { GenreForm, GenreRow, GenreService } from '../../ServerTypes/MovieDB';

@Decorators.registerClass('MovieTutorial.MovieDB.GenreDialog')
export class GenreDialog extends EntityDialog<GenreRow, any> {

    protected override getFormKey() { return GenreForm.formKey; }
    protected override getRowDefinition() { return GenreRow; }
    protected override getService() { return GenreService.baseUrl; }

    protected form = new GenreForm(this.idPrefix);
}