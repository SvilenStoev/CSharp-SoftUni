class Box<T> {
    data: Array<T> = [];

    get count(): number {
        return this.data.length;
    }

    add(element: T): void {
        this.data.push(element);
    }

    remove(): void {
        this.data.pop();
    };
}

let box = new Box<Number>();
box.add(1);
box.add(2);
box.add(3);
console.log(box.count);
console.log(box);
