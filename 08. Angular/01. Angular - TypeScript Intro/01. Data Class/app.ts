class MyRequest {
    constructor(
        method: string,
        uri: string,
        version: string,
        message: string) { }

    response: string = undefined;
    fulfilled: boolean = false;    
}

let myData = new MyRequest('GET', 'http://google.com', 'HTTP/1.1', '');