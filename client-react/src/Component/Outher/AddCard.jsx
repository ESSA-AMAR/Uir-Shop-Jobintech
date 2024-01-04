import React from 'react'
import tennu from '../../assets/tennu.png'
import x from '../../assets/x.png'

export default function AddCard() {
  return (
    <div className='bg-[#FDFDFD] shadow-2xl w-full h-[300px] rounded-[20px] my-5  py-3 px-5'>
      <h1 className='text-center text-[30px] text-[#183761]'>SHOPPING CART </h1>
      <div className='w-full flex my-9 text-[#183761] mx-auto px-6'>
        <div className='w-[40%] text-[20px]'>Products</div>
        <div className='w-[15%] text-[20px]'>Price</div>
        <div  className='w-[15%] text-[20px] '>Quantity</div>
        <div  className='w-[15%] text-[20px] '>Total</div>
        <div  className='w-[15%] text-[20px] '>Remove</div>
      </div>
      <div className='w-full flex items-center my-9 text-[#183761] mx-auto px-6'>
        <div className='w-[40%] text-[20px] flex gap-4 items-center'>
            <img src={tennu} alt="" className='w-[50px]' />
            <p>T-Shirt Polo Uir pride Monche courte</p>
        </div>
        <div  className='w-[15%] text-[20px] '>50.25 MAD</div>
        <div className='w-[15%] text-[20px] flex gap-3'>
            <div className='border-[1px] py-2 rounded-full flex justify-center items-center px-2 cursor-pointer's>-</div>
            <div className='border-[1px] py-2  rounded-2xl px-4'>1</div>
            <div className='border-[1px] py-2 rounded-full flex justify-center items-center px-2 cursor-pointer'>+</div>
        </div>
        <div  className='w-[15%] text-[20px] '>50.25 MAD</div>
        <div  className='w-[15%] text-[20px] '>
            <img src={x} alt="" className='bg-[#C9CE19] px-4 py-4 rounded-full cursor-pointer' />
        </div>
      </div>
    </div>
  )
}
