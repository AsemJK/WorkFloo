// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    $(document).on("click", "#mobileViewMenu", function (e) {
        e.stopPropagation();
        CloseMobileViewMenu();
    });
});
function CloseMobileViewMenu() {
    // Close the mobile view menu
    var mobileViewMenu = document.getElementById("mobileViewMenu");
    mobileViewMenu.classList.remove("lg:hidden");
    mobileViewMenu.classList.add("hidden");

}
function OpenMobileViewMenu() {
    // Open the mobile view menu
    var mobileViewMenu = document.getElementById("mobileViewMenu");
    mobileViewMenu.classList.remove("hidden");
    mobileViewMenu.classList.add("lg:hidden");
}