import React,{useState} from 'react'
const ssuggestions=[
    "laptop",
    "mobile",
    "phone",
    "phone"
];
export default function Useeffect() {
     const [search,setsearch]=React.useState("")
    const [recommendation,setRecommendations]=React.useState(ssuggestions)
    React.useEffect(()=>{
       setRecommendations(ssuggestions.filter((elem)=>elem.includes(search)))
       return()=>{
        console.log("cleanup")
       }
    },[search]);

  return (
    <div>
      <input type="text" value={search} onChange={(e)=>{setsearch(e.target.value)}} />
      {
        recommendation.map((element,index)=><div key={index}>{index}.{element}</div>)
      }
    </div>
  )
}
