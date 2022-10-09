class Ticket {
    _destination: string;
    _price: number;
    _status: string;

    constructor(destination: string, price: number, status: string) {
        this._destination = destination;
        this._price = price;
        this._status = status;
    }
}

function ticketsDatabase(ticketDescriptions: string[], sortType: string): Ticket[] {
    const tickets = Array<Ticket>();

    for (let ticketDescription of ticketDescriptions) {
        const ticketArr = ticketDescription.split('|');
        const ticketPrice = Number(ticketArr[1]);
        const ticket = new Ticket(ticketArr[0], ticketPrice, ticketArr[2],);

        tickets.push(ticket);
    }

    if (sortType == 'destination') {
        tickets.sort((a, b) => a._destination.localeCompare(b._destination));
    } else if (sortType == 'status') {
        tickets.sort((a, b) => a._status.localeCompare(b._status));
    } else if (sortType == 'price') {
        tickets.sort((a, b) => b._price - a._price);
    }

    return tickets;
}

console.log(ticketsDatabase([
    'Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'
],
    'status'));