const result = document.querySelector('#root')

const link = document.querySelector('#link')
link.addEventListener('click', (event)=>{
    console.log("Arrow Function : "+ this +" and event source is : "+ event); // this = window
})

const link2 = document.querySelector('#link')
link2.addEventListener('click', function(event){
    console.log("Simple Function : "+ this +" and event source is : "+ event); // this = link
})

function clickFunction(){
    result.innerHTML += "<h2>Clické</h2>"
}