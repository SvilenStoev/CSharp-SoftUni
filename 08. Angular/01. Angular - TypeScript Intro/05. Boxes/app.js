class Box {
    constructor() {
        this.data = [];
    }
    get count() {
        return this.data.length;
    }
    add(element) {
        this.data.push(element);
    }
    remove() {
        this.data.pop();
    }
    ;
}
let box = new Box();
box.add(1);
box.add(2);
box.add(3);
console.log(box.count);
console.log(box);
