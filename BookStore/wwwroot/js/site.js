$(document).ready(function () {
    $(".btn-delete").on("click", function () {
        if (!confirm("Are you sure to delete this book ?")) {
            return false;
        }
    });
});