import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TestTableForm, TestTableRow, TestTableService } from '../../ServerTypes/Test';

@Decorators.registerClass('RedisTest.Test.TestTableDialog')
export class TestTableDialog extends EntityDialog<TestTableRow, any> {
    protected getFormKey() { return TestTableForm.formKey; }
    protected getIdProperty() { return TestTableRow.idProperty; }
    protected getLocalTextPrefix() { return TestTableRow.localTextPrefix; }
    protected getNameProperty() { return TestTableRow.nameProperty; }
    protected getService() { return TestTableService.baseUrl; }
    protected getDeletePermission() { return TestTableRow.deletePermission; }
    protected getInsertPermission() { return TestTableRow.insertPermission; }
    protected getUpdatePermission() { return TestTableRow.updatePermission; }

    protected form = new TestTableForm(this.idPrefix);
}