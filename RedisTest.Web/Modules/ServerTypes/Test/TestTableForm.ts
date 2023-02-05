import { PrefixedContext, IntegerEditor, StringEditor } from '@serenity-is/corelib';
import { initFormType } from '@serenity-is/corelib/q';

export interface TestTableForm {
    Test: StringEditor;
    Test2: IntegerEditor;
}

export class TestTableForm extends PrefixedContext {
    static formKey = 'Test.TestTable';
	private static init: boolean;
	
	constructor(prefix: string) {
	    super(prefix);
		if (!TestTableForm.init)  {
		    TestTableForm.init = true;
			
			var w0 = IntegerEditor;
			var w1 = StringEditor;

			initFormType(TestTableForm, [
			'Test', w1,
			'Test2', w0,
			]);
		}
    }
}