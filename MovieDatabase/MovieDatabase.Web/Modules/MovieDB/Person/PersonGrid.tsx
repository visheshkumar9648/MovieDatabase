import { EntityGrid } from '@serenity-is/corelib';
import { PersonColumns, PersonRow, PersonService } from '../../ServerTypes/MovieDB';
import { PersonDialog } from './PersonDialog';

export class PersonGrid extends EntityGrid<PersonRow> {
    static override [Symbol.typeInfo] = this.registerClass("MovieDatabase.MovieDB.");

    protected override getColumnsKey() { return PersonColumns.columnsKey; }
    protected override getDialogType() { return PersonDialog; }
    protected override getRowDefinition() { return PersonRow; }
    protected override getService() { return PersonService.baseUrl; }
}