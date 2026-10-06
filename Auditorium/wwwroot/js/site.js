$(function ()
{
	//alert("OK!");

	$(".label__kids").addClass("unselected");

	$("body").on("click", ".input__kids", function()
	{
		var seatId = $(this).attr("data-id");
		$(".label__kids[data-id=" + seatId + "]").toggleClass("unselected selected");
	});
})