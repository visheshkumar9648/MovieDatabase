import { Decorators, EntityGrid, first, localText, LookupEditor, QuickSearchField } from '@serenity-is/corelib';
import { MovieColumns, MovieListRequest, MovieRow, MovieService } from '../../ServerTypes/MovieDB';
import { MovieDialog } from './MovieDialog';

@Decorators.registerClass('MovieTutorial.MovieDB.MovieGrid')
export class MovieGrid extends EntityGrid<MovieRow> {

    protected override getColumnsKey() { return MovieColumns.columnsKey; }
    protected override getDialogType() { return MovieDialog; }
    protected override getRowDefinition() { return MovieRow; }
    protected override getService() { return MovieService.baseUrl; }

    protected override getQuickSearchFields(): QuickSearchField[] {
        const txt = s => localText(`Db.${MovieRow.localTextPrefix}.${s}`);
        const fld = MovieRow.Fields;
        return [
            { name: "", title: "All" },
            { name: fld.Description, title: txt(fld.Description) },
            { name: fld.Storyline, title: txt(fld.Storyline) },
            { name: fld.Year, title: txt(fld.Year) }
        ];
    }

    protected override getQuickFilters() {
        let items = super.getQuickFilters();

        const genreListFilter = first(items, x =>
            x.field == MovieRow.Fields.GenreList);

        genreListFilter.handler = h => {
            const request = (h.request as MovieListRequest);
            const values = (h.widget as LookupEditor).values;
            request.Genres = values.map(x => parseInt(x, 10));
            h.handled = true;
        };

        return items;
    }
}
