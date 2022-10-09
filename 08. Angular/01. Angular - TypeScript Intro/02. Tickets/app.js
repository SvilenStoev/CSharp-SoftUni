var Ticket = /** @class */ (function () {
    function Ticket(destination, price, status) {
        this._destination = destination;
        this._price = price;
        this._status = status;
    }
    return Ticket;
}());
function ticketsDatabase(ticketDescriptions, sortType) {
    var tickets = Array();
    for (var _i = 0, ticketDescriptions_1 = ticketDescriptions; _i < ticketDescriptions_1.length; _i++) {
        var ticketDescription = ticketDescriptions_1[_i];
        var ticketArr = ticketDescription.split('|');
        var ticketPrice = Number(ticketArr[1]);
        var ticket = new Ticket(ticketArr[0], ticketPrice, ticketArr[2]);
        tickets.push(ticket);
    }
    if (sortType == 'destination') {
        tickets.sort(function (a, b) { return a._destination.localeCompare(b._destination); });
    }
    else if (sortType == 'status') {
        tickets.sort(function (a, b) { return a._status.localeCompare(b._status); });
    }
    else if (sortType == 'price') {
        tickets.sort(function (a, b) { return b._price - a._price; });
    }
    return tickets;
}
console.log(ticketsDatabase([
    'Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'
], 'status'));
