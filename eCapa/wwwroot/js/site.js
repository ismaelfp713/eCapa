function printInvoke() {
    window.print();
}
function TestDataTablesAdd(table) {
    $(document).ready(function () {
        $(table).DataTable();
    });
}
function TestDataTablesRemove(table) {
    $(document).ready(function () {
        $(table).DataTable().destroy();
    });
}