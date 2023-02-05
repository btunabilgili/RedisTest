import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TestTableGrid } from './TestTableGrid';

$(function() {
    initFullHeightGridPage(new TestTableGrid($('#GridDiv')).element);
});