import React, { useEffect, useState } from 'react'
import axios from 'axios'
import './Product.css'

const Product = () => {

    const [product,setProduct]=useState([])
    const basepath="https://localhost:7126"

    //Getting from api
    const fetchProduct = async ()=>{
      try{
        const response = await axios.get(basepath + `/AdminSide/DisplayingAllItems`)
        setProduct(response.data)
      }
      catch(error)
      {
        console.log("Not Fetched")
      }
    }
   
    //post
    const productData={
      productSection:"Stationary",
      product:"Parker Pen",
      price:200,
      availableQuantity:15
    }

    const createProduct=async ()=>{
      try{
        const response= await axios.post(basepath+`/AdminSide/Updating the Values`,productData)
        setProduct(...product,response.data)
      }
      catch(error)
      {
        console.error(error)
      }
    }

    //put
    const updatedProdt={
      productSection:"Stationary",
      product:"Parker Pen",
      price:100,
      availableQuantity:20
    }

    const updateProduct=async(id)=>{
      try{
        const response=await axios.put(basepath+`/AdminSide/${id}`,updatedProdt)
        const upd= product.map((product)=>{
          if(product.productId === id)
          {
            return response.data
          }
          return product
        })
        setProduct(upd)
      }
      catch(error)
      {
        console.error(error)
      }

    }



    useEffect(()=>{fetchProduct()},[product])

  return (
    <div>
      <h2>Product Details</h2>
      <button onClick={createProduct}>Click to add</button>
      <div className='box'>
        <div> 
          {product.map((prodt)=>(
            <div key={prodt.productId}>
              <p>ProductId:{prodt.productId}</p>
              <p>Product Section:{prodt.productSection}</p>
              <p>Product Name:{prodt.product}</p>
              <p>Price:{prodt.price}</p>
              <p>Quantity:{prodt.availableQuantity}</p>
              <button onClick={()=>{updateProduct(prodt.productId)}}>Update</button>
            </div>
          ))}
        </div>
      </div>
    </div>
  )
}

export default Product
