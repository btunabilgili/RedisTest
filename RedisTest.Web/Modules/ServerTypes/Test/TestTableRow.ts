import { fieldsProxy } from '@serenity-is/corelib/q';

export interface TestTableRow {
    Id?: number;
    Test?: string;
    Test2?: number;
}

export abstract class TestTableRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Test';
    static readonly localTextPrefix = 'Test.TestTable';
	
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TestTableRow>();
}