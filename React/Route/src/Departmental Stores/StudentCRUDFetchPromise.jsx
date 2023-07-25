import React from 'react'

const StudentCRUDFetchPromise = () => {

    
    const [product,setProduct]=useState([])
    const [newProduct,setNewProduct]=useState({
        productSection:"",
        product:"",
        price:'',
        availableQuantity:''
    });
    const basepath="https://localhost:7126"

    //Getting from api
    const fetchProduct = async ()=>{
    //   try{
    //     const response = await axios.get(basepath + `/AdminSide/DisplayingAllItems`)
    //     setProduct(response.data)
    //   }
    //   catch(error)
    //   {
    //     console.log("Not Fetched")
    //   }
    fetch('https://localhost:7126/AdminSide/DisplayingAllItems')
    .then((response)=>response.json())
    .then((data)=>setProduct(data))
    .then((error)=>console.error(error))
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
          <h1>Student CRUD Operations</h1>
          <h2>Create Student</h2>
          <input
            type="text"
            placeholder="Name"
            value={newStudent.name}
            onChange={(e) => setNewStudent({ ...newStudent, name: e.target.value })}
          />
          <input
            type="text"
            placeholder="City"
            value={newStudent.city}
            onChange={(e) => setNewStudent({ ...newStudent, city: e.target.value })}
          />
          <input
            type="number"
            placeholder="Pin"
            value={newStudent.pin}
            onChange={(e) => setNewStudent({ ...newStudent, pin: e.target.value })}
          />
          <button onClick={createStudent}>Create Student</button>
    
          <h2>Update Students</h2>
          <ul>
            {students.map((student) => (
              <li key={student.studId}>
                <span>{student.name}</span>
                <span>{student.city}</span>
                <span>{student.pin}</span>
                <button onClick={() => updateStudent(student.studId, { name: 'Updated Name' })}>Update</button>
                <button onClick={() => deleteStudent(student.studId)}>Delete</button>
              </li>
            ))}
          </ul>
        </div>)
}

export default StudentCRUDFetchPromise
