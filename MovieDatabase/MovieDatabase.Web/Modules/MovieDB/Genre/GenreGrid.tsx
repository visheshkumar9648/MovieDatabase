import { EntityGrid } from '@serenity-is/corelib';
import { GenreColumns, GenreRow, GenreService } from '../../ServerTypes/MovieDB';
import { GenreDialog } from './GenreDialog';

export class GenreGrid extends EntityGrid<GenreRow> {
    static override [Symbol.typeInfo] = this.registerClass("MovieDatabase.MovieDB.");

    protected override getColumnsKey() { return GenreColumns.columnsKey; }
    protected override getDialogType() { return GenreDialog; }
    protected override getRowDefinition() { return GenreRow; }
    protected override getService() { return GenreService.baseUrl; }
}