var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        search: false,
        "ajax": {
            "url": "/Course/Course/GetAll"
            //"url": "/api/courses"
        },
        "columns": [
            { "data": "name" },
            { "data": "trainingDates"},
            { "data": "trainingVenue"},
            { "data": "seatsLeft" },
            { "data": "lastDateOfRegistration" },
            { "data": "price"},
            { "data": "description" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                                    <a href="/Area/Course/Upsert/${data}" class="btn btn-outline-success btn-sm" style="cursor:pointer"><i class="fas fa-user-edit"></i> Edit</a>
                                    <a href="/Area/Course/Delete/${data}" class="btn btn-outline-danger btn-sm" style="cursor:pointer"><i class="fas fa-trash-alt"></i> Delete</a>
                            `;
                }
            }
        ]
    });
}