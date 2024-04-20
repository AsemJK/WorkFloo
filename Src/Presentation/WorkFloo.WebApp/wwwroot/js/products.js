$(function () {
    FillProducts();
})

function FillProducts() {
    $.ajax({
        url: "/api/v1/product/getPagedListProduct?pagesize=99999",
        type: "GET",
        success: function (data) {
            console.log(data);
            var dataTable = $('#productsTable').DataTable({
                columns: [
                    { data: "id" },
                    { data: "name" },
                    { data: "price" },
                    { data: "barCode" },
                    {
                        data: null,
                        render: function (data, type, row) {
                            return `<button class="btn btn-primary" onclick="EditProduct(${data.id})">Edit</button>
                                    <button class="btn btn-danger" onclick="DeleteProduct(${data.id})">Delete</button>`;
                        }
                    }
                ]
            });
            dataTable.clear();
            dataTable.rows.add(data.data);
            dataTable.draw();

        },
        error: function (error) {
            console.log(error);
        }
    });
}