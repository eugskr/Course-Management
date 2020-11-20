// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {  
    

    $('.eventItem').hover(eventItemMouseEnterHandler, eventItemMouseLeaveHandler);

    function eventItemMouseEnterHandler(event) {
        let currentTarget = $(event.currentTarget);
        let startDate = new Date(currentTarget.children(".startDate").data("startDate"));
        let endDate = new Date(currentTarget.children(".endDate").data("endDate"));
      
       

        __calendar.addEvent({
            id: 1,
            startTime: formatDateToTime(startDate),
            endTime: formatDateToTime(endDate),
            display: 'background',
            startRecur: formatDate(startDate),
            daysOfWeek: [formatWeekDay(startDate)],
        });
    }
    function eventItemMouseLeaveHandler(event) {
        var event = __calendar.getEventById(1);
        if (event) event.remove();
    }

    function formatDateToTime(date) {
        var hours = date.getHours();
        var minutes = (date.getMinutes() < 10 ? '0' : '') + date.getMinutes();
        return `${hours}:${minutes}:00`;
    }
    function formatDate(date) {
        var year = date.getYear();
        var month = date.getMonth();
        var day = date.getDay();
        return `${year}-${month}-${day}`;
    }
    function formatWeekDay(date) {
        var days = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
        
        return days.indexOf(days[date.getDay()]);
    }
})

