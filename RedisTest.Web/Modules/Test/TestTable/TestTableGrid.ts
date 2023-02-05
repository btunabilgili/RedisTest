import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TestTableColumns, TestTableRow, TestTableService } from '../../ServerTypes/Test';
import { TestTableDialog } from './TestTableDialog';

@Decorators.registerClass('RedisTest.Test.TestTableGrid')
export class TestTableGrid extends EntityGrid<TestTableRow, any> {
    protected getColumnsKey() { return TestTableColumns.columnsKey; }
    protected getDialogType() { return TestTableDialog; }
    protected getIdProperty() { return TestTableRow.idProperty; }
    protected getInsertPermission() { return TestTableRow.insertPermission; }
    protected getLocalTextPrefix() { return TestTableRow.localTextPrefix; }
    protected getService() { return TestTableService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}