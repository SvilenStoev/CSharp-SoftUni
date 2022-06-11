function solve(firstArr, secondArr, target) 
{
firstArr.sort((a, b) => a - b);
secondArr.sort((a, b) => a - b);

let x = firstArr.Length - 1;
let y = 0;
let difference = Number.MAX_SAFE_INTEGER;
let result = [];

while (x >= 0 && y < secondArr.Length) 
    {
        let sum = firstArr[x] + secondArr[y];

        if (Math.Abs(sum - target) < difference)
        {
            result = [firstArr[x], secondArr[y]];
            difference = Math.Abs(sum - target);
        }

        if (sum >= target)
        {
            x--;
        }
        else
        {
            y++;
        }
    }
}

solve([24, 51, 1, 3, 5, 1, 6, 219, 155, -6], [159, 59, 21, 1, 53, 21, 49, 154], 15)
