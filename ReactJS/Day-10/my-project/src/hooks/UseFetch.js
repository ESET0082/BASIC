import axios from "axios";
import { useEffect, useState } from "react"

const useFetch = (url)=>{
  const [loading,setLoading]=useState(false)
  const [error,setError]=useState(null)
  const [data,setData]=useState(null);

  const getData = async() => {
    try{
        setLoading(true)
        // fetch(url,{
        //   headers :
        //   {
        //     'Authorization':"Bearer<token>"
        //   }
        // })
        const response=await axios.get(url)
        setData(response.data)
    }
    catch(error)
    {
        setError(error)
    }
    finally{

    }
  }
  useEffect(()=>{
    getData()
  },[]);

  retrun [loading,data,error]
}