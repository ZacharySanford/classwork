let planets = [
   {
    name: "Mercury",
    inner: true,
    diameter: 3031.9,
    color: "#696969"
   },
   {
    name: "Venus",
    inner: true,
    diameter: 7520.8,
    color: "#b89165"
   },
   {
    name: "Earth",
    inner: true,
    diameter:7917.5,
    color: "#5a5b86"
   },
   {
    name: "Mars",
    inner: true,
    diameter:4212.3,
    color: "#df8c4e",
   },
   {
    name: "Jupiter",
    inner: false,
    diameter: 86881,
    color: "#f6a049"
   },
   {
    name: "Saturn",
    inner: false,
    diameter: 72367,
    color: "#dcd3a1"
   },
   {
    name: "Uranus",
    inner: false,
    diameter: 31518,
    color: "#b4d9df"
   },
   {
    name: "Neptune",
    inner: false,
    diameter: 30599,
    color: "#456eff"
   }
]
let index = 0;
planets.forEach(planetNames);

function planetNames(planets){
    console.log(planets.name)
}

function averageDiameter(planets){
    let sum = 0;
    let planetCount = 0;
    for(let i = 0; i <planets.length; i++)
    {
        sum += planets[i].diameter;
        planetCount++
    }
    let average = sum / planetCount;
    return average;
}

function decrementCount(){
    index --;
    if(index <= 0){
        document.getElementById('previous').style.visibility = 'hidden';
    }else if(index < 7){
        document.getElementById('next').style.visibility = 'visible';
    }
    document.getElementById('index').textContent = index;
}

function incrementCount(){
    index ++;
    if(index >= 7){
         document.getElementById('next').style.visibility = 'hidden';
    }else if(index > 0){
        document.getElementById('previous').style.visibility = 'visible';
    }
    document.getElementById('index').textContent = index;
}
function updateDiameter(){
    let newDiameter = planets[index].diameter/100
}
function updatePlanetDisplay(){
    document.getElementById('planetName').textContent = planets[index].name;
    if(planets[index].inner){
        document.getElementById('planetType').textContent = "Inner Planet";
    } else {
        document.getElementById('planetType').textContent = "Outer Planet";
    }
    const planetImage = document.getElementById('planetSize');
    planetImage.style.backgroundColor = planets[index].color;

    const planetResize = planets[index].diameter / 100;
    planetImage.style.width = planetResize +"px";
    planetImage.style.height = planetResize + "px";
}
window.onload = function(){
    updatePlanetDisplay();
}



