// nav

$(document).on("click", "nav ul li a", function () {
	const links = [...document.querySelectorAll('nav ul li a')];
	links.forEach(link => link.classList.remove("active"));
	$(this).addClass("active");
});

// burger

$(document).on("click", ".hamburger", function () {
	// $("nav").toggleClass('active');
	// $(this).toggleClass('is-active');
	const nav = document.querySelector('nav');
	nav.classList.toggle('active');
	$(this).toggleClass('is-active');

	const links = [...document.querySelectorAll('nav ul li a')];
	links.forEach(link => link.classList.remove("active"));
	$(this).addClass("active");
});


// tabs

$(document).on("click", ".naccs .menu div", function () {
	var numberIndex = $(this).index();
	if (!$(this).is("active")) {
		$(".naccs .menu div").removeClass("active");
		$(".naccs ul li").removeClass("active");
		$(this).addClass("active");
		$(".naccs ul").find("li:eq(" + numberIndex + ")").addClass("active");
	}
});

// slider

$(document).ready(function () {
	$('.customer_wrapper').slick({
		// infinite: true,
		slidesToShow: 3,
		slidesToScroll: 3,
		responsive: [
			{
				breakpoint: 1024,
				settings: {
					slidesToShow: 2,
					slidesToScroll: 2,
				}
			},
			{
				breakpoint: 680,
				settings: {
					slidesToShow: 1,
					slidesToScroll: 1
				}
			}
		]
	});
});

// slow scrolling

$(document).ready(function () {
	$('a[href*=#]').bind("click", function (e) {
		var anchor = $(this);
		$('html, body').stop().animate({
			scrollTop: $(anchor.attr('href')).offset().top
		}, 1000);
		e.preventDefault();
	});
	return false;
});

