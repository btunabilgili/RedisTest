import{a as d,b as c,c as e,d as n}from"../../../_chunks/chunk-MNHJHLJ6.js";import{a as o,b as s,c as i,e as l,f as m}from"../../../_chunks/chunk-K3EI6ARL.js";var u=s(l(),1);var a=s(m(),1);var t=class extends a.EntityDialog{constructor(){super(...arguments);this.form=new c(this.idPrefix)}getFormKey(){return c.formKey}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getNameProperty(){return e.nameProperty}getService(){return n.baseUrl}};o(t,"LanguageDialog"),t=i([a.Decorators.registerClass("RedisTest.Administration.LanguageDialog")],t);var p=s(m(),1);var r=class extends p.EntityGrid{useAsync(){return!0}getColumnsKey(){return d.columnsKey}getDialogType(){return t}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getService(){return n.baseUrl}afterInit(){super.afterInit()}getDefaultSortBy(){return[e.Fields.LanguageName]}};o(r,"LanguageGrid"),r=i([p.Decorators.registerClass("RedisTest.Administration.LanguageGrid")],r);$(function(){(0,u.initFullHeightGridPage)(new r($("#GridDiv")).element)});
//# sourceMappingURL=LanguagePage.js.map
