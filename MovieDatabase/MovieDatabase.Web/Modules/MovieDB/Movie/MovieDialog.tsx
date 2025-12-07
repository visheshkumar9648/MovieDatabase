import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { MovieForm, MovieRow, MovieService } from '../../ServerTypes/MovieDB';
import "./MovieDialog.css";

@Decorators.panel()
@Decorators.registerClass('MovieDatabase.MovieDB.MovieDialog')
export class MovieDialog extends EntityDialog<MovieRow, any> {
    //static override [Symbol.typeInfo] = this.registerClass("MovieDatabase.MovieDB.");

    protected override getFormKey() { return MovieForm.formKey; }
    protected override getRowDefinition() { return MovieRow; }
    protected override getService() { return MovieService.baseUrl; }

    protected form = new MovieForm(this.idPrefix);
}