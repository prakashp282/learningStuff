let algorithmRunning = false;
const dataSetLengthInputRef = document.getElementById("dataSet");
const searchInputRef = document.getElementById("search");
const activeAlgorithmRef = document.getElementById("activeAlgorithm");
const activeAlgorithmResultRef = document.getElementById("activeAlgorithmResult");
const resultRef = document.getElementById("result");
let dataSetArray = [];

function resetData(length) {
  dataSetArray = [];
  for (let i = 0; i < length; i++) {
    dataSetArray.push(getRandomInt());
  }
  return dataSetArray;
}

function getRandomInt() {
  return Math.floor(Math.random() * 100) + 1;
}

function linearSearch() {
  if (algorithmRunning) {
    return alert(
      "Algorithm is running. Please wait or refresh the page."
    );
  }

  if (!dataSetLengthInputRef.value) {
    alert("Data set size is required");
    return;
  }

  if (dataSetLengthInputRef.value > 40) {
    alert("Data set size must be in range 1 - 40");
    return;
  }

  if (!searchInputRef.value) {
    alert("Search number is required");
    return;
  }
  activeAlgorithmRef.innerText = "Linear Search Algorithm is running";
  activeAlgorithmResultRef.innerText = "";
  if (dataSetArray.length == 0) {
    const inputValue = dataSetLengthInputRef.value;
    resetData(inputValue);
  }
  const searchInputValue = searchInputRef.value;

  function recursion(i) {
    if (dataSetArray[i] == searchInputValue) {
      changeSearchBarColor(dataSetArray, i, true);
      algorithmRunning = false;
      activeAlgorithmRef.innerText = "Linear Search";
      activeAlgorithmResultRef.innerText = "Found on index " + i;
      return i;
    }
    changeSearchBarColor(dataSetArray, i);

    if (i === dataSetArray.length - 1) {
      algorithmRunning = false;
      changeSearchBarColor(dataSetArray, -1);
      activeAlgorithmRef.innerText = "Linear Search";
      activeAlgorithmResultRef.innerText = "Number not found!!!";
      return false;
    }
    setTimeout(() => {
      recursion(++i);
    }, 1000);
  }
  algorithmRunning = true;
  recursion(0);
}

function binarySearch() {
  if (algorithmRunning) {
    return alert(
      "Algorithm is running. Please wait or refresh the page."
    );
  }

  if (!dataSetLengthInputRef.value) {
    alert("Data set size is required");
    return;
  }

  if (dataSetLengthInputRef.value > 40) {
    alert("Data set size must be in range 1 - 40");
    return;
  }

  if (!searchInputRef.value) {
    alert("Search number is required");
    return;
  }
  activeAlgorithmRef.innerText = "Binary Search Algorithm is running";
  activeAlgorithmResultRef.innerText = "";
  const searchInputValue = searchInputRef.value;
  if (dataSetArray.length == 0) {
    const inputValue = dataSetLengthInputRef.value;
    resetData(inputValue);
  }
  var lowIndex = 0;
  var highIndex = dataSetArray.length - 1;

  function recursion(sortedArray) {
    if (lowIndex <= highIndex) {
      var midIndex = Math.floor((lowIndex + highIndex) / 2);
      changeSearchBarColor(sortedArray, midIndex);
      if (sortedArray[midIndex] == searchInputValue) {
        changeSearchBarColor(sortedArray, midIndex, true);
        algorithmRunning = false;
        activeAlgorithmRef.innerText = "Binary Search";
        activeAlgorithmResultRef.innerText = "Found on index " + midIndex;
        return midIndex;
      } else if (sortedArray[midIndex] < parseInt(searchInputValue)) {
        lowIndex = midIndex + 1;
      } else {
        highIndex = midIndex - 1;
      }
      setTimeout(() => {
        recursion(sortedArray);
      }, 1000);
    } else {
      algorithmRunning = false;
      changeSearchBarColor(sortedArray, -1);
      activeAlgorithmRef.innerText = "Binary Search";
      activeAlgorithmResultRef.innerText = "Number not found!!!";
      return false;
    }
  }
  algorithmRunning = true;
  recursion(dataSetArray.sort((a, b) => a - b));
}

function changeSearchBarColor(array, activeIndex, active) {
  let htmlString = "";
  for (let i = 0; i < array.length; i++) {
    htmlString += `
    <div class="d-flex position-relative" 
    style="height: ${array[i]}%;">
      <div 
        class="${ active && activeIndex === i ? "bg-success" : activeIndex === i ? "bg-primary" : "bg-grey"} ml-2 bar">
      </div>
      <div>
        <p class="text-dark text-center position-absolute bar-value">${array[i]}</p>
      </div>
    </div>
    `;
  }
  resultRef.innerHTML = htmlString;
}

function selectionSort() {
  if (algorithmRunning) {
    return alert(
      "Algorithm is running. Please wait or refresh the page."
    );
  }
  if (!dataSetLengthInputRef.value) {
    alert("Data set size is required");
    return;
  }

  if (dataSetLengthInputRef.value > 40) {
    alert("Data set size must be in range 1 - 40");
    return;
  }

  activeAlgorithmRef.innerText = "Selection Sort Algorithm is running";
  activeAlgorithmResultRef.innerText = "";
  if (dataSetArray.length == 0) {
    const inputValue = dataSetLengthInputRef.value;
    resetData(inputValue);
  }
  let sort = (inputArr) => {
    let len = inputArr.length;
    function recursion(i) {
      if (i < len - 1) {
        let min = i;
        for (let j = i + 1; j < len; j++) {
          (function (j) {
            setTimeout(function () {
              if (inputArr[min] > inputArr[j]) {
                min = j;
                changeSelectionSortBarColor(inputArr, min, j, true);
              } else {
                changeSelectionSortBarColor(inputArr, min, j);
              }
              if (j === len - 1) {
                if (min !== i) {
                  let tmp = inputArr[i];
                  inputArr[i] = inputArr[min];
                  inputArr[min] = tmp;
                  changeSelectionSortBarColor(inputArr, i, j);
                }
                recursion(++i);
              }
            }, 1000 * (j - i));
          })(j);
        }
      } else {
        algorithmRunning = false;
        activeAlgorithmRef.innerText = "Selection Sort Algorithm";
        activeAlgorithmResultRef.innerText = "Completed!!";
        changeSelectionSortBarColor(inputArr, -1, -1);
      }
    }
    recursion(0);
  };
  algorithmRunning = true;
  sort(dataSetArray);
}

function changeSelectionSortBarColor(array, minIndex, index) {
  let htmlString = "";
  for (let i = 0; i < array.length; i++) {
    htmlString += `
    <div class="d-flex position-relative" 
      style="height: ${array[i]}%;">
      <div
      class="${ !array[index] ? "bg-grey" : (minIndex === i || index === i) ? "bg-warning"
        : "bg-grey"
      } ml-2 d-flex align-items-end bar">
      </div>
      <div>
        <p class="text-dark text-center position-absolute bar-value">${array[i]}</p>
      </div>
    </div>
    `;
  }
  resultRef.innerHTML = htmlString;
}

function bubbleSort() {
  if (algorithmRunning) {
    return alert(
      "Algorithm is running. Please wait or refresh the page."
    );
  }
  if (!dataSetLengthInputRef.value) {
    alert("Data set size is required");
    return;
  }

  if (dataSetLengthInputRef.value > 40) {
    alert("Data set size must be in range 1 - 40");
    return;
  }

  activeAlgorithmRef.innerText = "Bubble Sort Algorithm is running";
  activeAlgorithmResultRef.innerText = "";
  if (dataSetArray.length == 0) {
    const inputValue = dataSetLengthInputRef.value;
    resetData(inputValue);
  }

  let sort = (inputArr) => {
    let len = inputArr.length;
    function recursion(i, swapped) {
      if (i < len) {
        for (let j = 0; j < (len - i); j++) {
          (function (j) {
            setTimeout(function () {
              if (inputArr[j] > inputArr[j + 1]) {
                changeBubbleSortBarColor(inputArr, j, j + 1, true);
                let tmp = inputArr[j];
                inputArr[j] = inputArr[j + 1];
                inputArr[j + 1] = tmp;
                swapped = true;
              } else {
                changeBubbleSortBarColor(inputArr, j, j + 1);
              }
              if (j === (len - i - 1)) {
                if (swapped === true) {
                  swapped = false;
                  recursion(++i, true);
                }
              }
            }, 1000 * j);
          })(j);
        }
      } else {
        algorithmRunning = false;
        activeAlgorithmRef.innerText = "Bubble Sort Algorithm";
        activeAlgorithmResultRef.innerText = "Completed!!";
        changeBubbleSortBarColor(inputArr, -1, -1);
      }
    }
    recursion(0, false);
  };
  algorithmRunning = true;
  sort(dataSetArray);
}

function changeBubbleSortBarColor(array, leftIndex, rightIndex, swap) {
  let htmlString = "";

  for (let i = 0; i < array.length; i++) {
    htmlString += `
    <div class="d-flex position-relative" 
      style="height: ${array[i]}%;">
      <div
      class="${ !array[rightIndex] ? "bg-grey" : swap && (leftIndex === i || rightIndex === i) ? "bg-warning"
        : leftIndex === i || rightIndex === i ? "bg-info" : "bg-grey"
      } ml-2 d-flex align-items-end bar">
      </div>
      <div>
        <p class="text-dark text-center position-absolute bar-value">${array[i]}</p>
      </div>
    </div>
    `;
  }
  resultRef.innerHTML = htmlString;
}

function randomArray() {
  if (algorithmRunning) {
    alert(
      "Algorithm is running. Please wait or refresh the page."
    );
    return;
  }

  if (!dataSetLengthInputRef.value) {
    alert("Data set size is required");
    return;
  }

  if (dataSetLengthInputRef.value > 40) {
    alert("Data set size must be in range 1 - 40");
    return;
  }
  let htmlString = "";

  const inputValue = dataSetLengthInputRef.value;
  const dataSetArray = resetData(inputValue);
  for (let i = 0; i < dataSetArray.length; i++) {
    htmlString += `
    <div class="d-flex position-relative" 
      style="height: ${dataSetArray[i]}%;">
      <div
      class="bg-grey ml-2 d-flex align-items-end bar">
      </div>
      <div>
        <p class="text-dark text-center position-absolute bar-value">${dataSetArray[i]}</p>
      </div>
    </div>
    `;
  }
  resultRef.innerHTML = htmlString;
}

function reset() {
  if (algorithmRunning) {
    alert(
      "Algorithm is running. Please wait or refresh the page."
    );
    return;
  }
  resultRef.innerHTML = '';
  document.getElementById("dataSet").value = '';
  document.getElementById("search").value = '';
  activeAlgorithmRef.innerText = "";
  activeAlgorithmResultRef.innerText = "";

}
