import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from '@serenity-is/corelib';
import { TestTableRow } from './TestTableRow';
import { serviceRequest } from '@serenity-is/corelib/q';

export namespace TestTableService {
    export const baseUrl = 'Test/TestTable';

    export declare function Create(request: SaveRequest<TestTableRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TestTableRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TestTableRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TestTableRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods {
        Create: "Test/TestTable/Create",
        Update: "Test/TestTable/Update",
        Delete: "Test/TestTable/Delete",
        Retrieve: "Test/TestTable/Retrieve",
        List: "Test/TestTable/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>TestTableService)[x] = function (r, s, o) { 
            return serviceRequest(baseUrl + '/' + x, r, s, o); 
        };
    });
}