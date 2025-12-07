import { Decorators, WidgetProps } from '@serenity-is/corelib';
import { GridEditorBase } from '@serenity-is/extensions';
import { MovieCastColumns, MovieCastRow, PersonRow } from '../../ServerTypes/MovieDB';
import { MovieCastEditDialog } from "./MovieCastEditDialog";

@Decorators.registerEditor("MovieDatabase.MovieDB.MovieCastEditor")
export class MovieCastEditor<P = {}> extends GridEditorBase<MovieCastRow, P> {

    protected override getColumnsKey() {
        return MovieCastColumns.columnsKey;
    }

    protected override getLocalTextPrefix() {
        return MovieCastRow.localTextPrefix;
    }

    constructor(props: WidgetProps<P>) {
        super(props);
    }

    protected override getDialogType() {
        return MovieCastEditDialog;
    }

    protected override getAddButtonCaption() {
        return "Add";
    }

    // ⭐ REQUIRED for PersonFullName to appear in grid
    protected override validateEntity(row: MovieCastRow, id: number) {

        if (!super.validateEntity(row, id))
            return false;

        const itemId = id ?? row[this.getIdProperty()];

        PersonRow.getLookupAsync().then(lookup => {
            const item = this.view?.getItemById(itemId);
            if (item) {
                item.PersonFullName = lookup.itemById[row.PersonId].FullName;
                this.view.updateItem(itemId, item);
            }
        });

        return true;
    }
}
