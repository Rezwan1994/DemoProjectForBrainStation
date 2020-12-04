var NavigatePageListing = function (pagenumber, order) {
    console.log("fff")
    var searchText = $(".srch-term").val();
    $("#LoadPostList").load("/Home/GetAllPosts", { PageNumber: pagenumber, SearchText: searchText });
}
var IncreaseLike = function (id) {
    var totalLike = 0;
    totalLike = $(".likeCount_" + id).html();
    totalLike = parseInt(totalLike)
    totalLike = totalLike + 1;
    $(".likeCount_" + id).html(totalLike);
}
var DecreaseLike = function (id) {
    var totalDislike = 0;
    totalDislike = $(".dislikeCount_" + id).html();
    totalDislike = parseInt(totalDislike)
    totalDislike = totalDislike + 1;
    $(".dislikeCount_" + id).html(totalDislike);
}
$(document).ready(function () {



    $(".srch-term").keyup(function () {

        NavigatePageListing(1, null);
    })


    NavigatePageListing(1, null);

});