// Note var antiForgeryToken should be declared in the Layout or View

// Append AntiForgeryTiken Input to Form
$('form').submit(function (event) {
    if ($(this).attr("method").toUpperCase() == "POST" && !$(this).find("[name=" + $(antiForgeryToken).attr("name") + "]").length) {
        //$(this).append($(antiForgeryToken));
    }
});

// Append AntiForgeryToken to Jquery Ajax Requests$.param()
$.ajaxPrefilter(function (options, originalOptions, jqXHR) {
    debugger;
    if (options.type.toUpperCase() == "POST") {
        if (!originalOptions.data.__RequestVerificationToken) {
            var token = { __RequestVerificationToken: $(antiForgeryToken).val() };
            var data = $.isArray(originalOptions.data) ? originalOptions.data[0] : originalOptions.data;
            $.extend(data, token);
            options.data = $.param(data);
        }
    }
});