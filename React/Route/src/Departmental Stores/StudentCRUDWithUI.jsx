import React, { useEffect, useState } from 'react'
import axios from 'axios'

const StudentCRUDWithUI = () => {

    
    const [product,setProduct]=useState([])
    const [newProduct,setNewProduct]=useState({
        productSection:"",
        product:"",
        price:'',
        availableQuantity:''
    })
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
      <h2>Product CRUD Details</h2>
      <h2>Create Student</h2>
              {/* auto generated since it is identity */}
      {/* <input
        type="text"
        placeholder="Id"
        value={newStudent.studId}
        onChange={(e) =>
          setNewStudent({ ...newProduct, studId: e.target.value })
        }
      /> */}
      <input
        type="text"
        placeholder="Name"
        value={newProduct.productSection}
        onChange={(e) => setNewProduct({ ...newProduct, productSection: e.target.value })}
      />
      <input
        type="text"
        placeholder="City"
        value={newProduct.product}
        onChange={(e) => setNewProduct({ ...newProduct, product: e.target.value })}
      />
      <input
        type="text"
        placeholder="Pin"
        value={newProduct.price}
        onChange={(e) => setNewProduct({ ...newProduct, price: e.target.value })}
      />
            <input
        type="text"
        placeholder="AvailableQuantity"
        value={newProduct.availableQuantity}
        onChange={(e) => setNewProduct({ ...newProduct, availableQuantity: e.target.value })}
      />
      <button onClick={createProduct}>Create Student</button>
      {/* <button onClick={createProduct}>Click to add</button> */}
      <div className='box'>
        <div> 
          {product.map((prodt)=>(
            <div key={prodt.productId}>
              <p>ProductId:{prodt.productId}</p>
              <p>Product Section:{prodt.productSection}</p>
              <p>Product Name:{prodt.product}</p>
              <p>Price:{prodt.price}</p>
              <p>Quantity:{prodt.availableQuantity}</p>
              {/* <button onClick={()=>{updateProduct(prodt.productId)}}>Update</button> */}

              {editStudent === student.studId ? (
              <React.Fragment>
                <input
                  type="text"
                  value={editStudent.studId}
                  onChange={(e) =>
                    setEditStudent({ ...editStudent, studId: e.target.value })
                  }
                />
                <input
                  type="text"
                  placeholder="Name"
                  value={editStudent.name}
                  onChange={(e) =>
                    setEditStudent({ ...editStudent, name: e.target.value })
                  }
                />
                <input
                  type="text"
                  placeholder="City"
                  value={editStudent.city}
                  onChange={(e) =>
                    setEditStudent({ ...editStudent, city: e.target.value })
                  }
                />
                <input
                  type="text"
                  placeholder="Pin"
                  value={editStudent.pin}
                  onChange={(e) =>
                    setEditStudent({ ...editStudent, pin: e.target.value })
                  }
                />
                <button onClick={() => updateStudent(student.studId)}>
                  Save
                </button>{" "}
                &nbsp; &nbsp; &nbsp;
                <button onClick={() => setEditStudent(null)}>
                  Cancel
                </button>{" "}
                &nbsp; &nbsp; &nbsp;
              </React.Fragment>
            ) : (
              <button onClick={() => { 
                setEditStudent(student.studId)
                console.log(editStudent.studId);
                 }}>
                Edit
              </button>
            )}
            <button onClick={() => deleteStudent(student.studId)}>
              Delete
            </button>
       
            </div>
          ))}
        </div>
      </div>
    </div>
  )
}

export default StudentCRUDWithUI
