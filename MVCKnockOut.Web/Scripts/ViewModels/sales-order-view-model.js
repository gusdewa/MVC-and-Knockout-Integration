/*
    Create a client-side view model that can be binded to HTML Views
*/

SalesOrderViewModel = function (data) {
    var self = this;

    // KO Mapping is a plugin for KnockOut JS to
    // automatically map all properties
    ko.mapping.fromJS(data, {}, self);
}