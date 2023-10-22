class MaxBinaryHeap {
    constructor() {
        this.values = []
    }

    insert(value) {
        this.values.push(value)

        this.bubbleUp()

    }

    bubbleUp() {
        var data = this.values
        var len = data.length
        var index = len - 1
        var parent = Math.floor((index - 1) / 2)

        while (index > 0) {
            if (data[index] > data[parent]) {
                var temp = data[index]
                data[index] = data[parent]
                data[parent] = temp
                index = parent
            } else
                break
        }

    }

}



var heap = new MaxBinaryHeap()
heap.insert(30)
heap.insert(20)
heap.insert(15)
heap.insert(10)
heap.insert(55)
