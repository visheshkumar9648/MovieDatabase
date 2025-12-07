import { Decorators } from "@serenity-is/corelib";
import { GridEditorDialog } from "@serenity-is/extensions";
import { MovieCastForm, MovieCastRow } from "../../ServerTypes/MovieDB";
import "./MovieCastEditDialog.css";

@Decorators.registerClass("MovieTutorial.MovieDB.MovieCastEditDialog")
export class MovieCastEditDialog extends GridEditorDialog<MovieCastRow> {
    protected override getFormKey() { return MovieCastForm.formKey; }
    protected override getNameProperty() { return MovieCastRow.nameProperty; }
    protected override getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

    protected form: MovieCastForm = new MovieCastForm(this.idPrefix);
}