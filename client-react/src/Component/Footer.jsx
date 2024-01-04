import React from 'react'

export default function Footer() {
  return (
    <div className='bg-[#C9CE19] w-full my-4 py-4 px-5 text-white rounded-[40px]'>
      <h1 className='flex justify-center items-center text-[45px]'>UIR<p className='text1 text-[45px]'>Shop</p></h1>
      <div className='flex justify-between my-7'>
        <div className='w-[20%]'>
          <h1 className='my-4 text-[35px] font-medium text-center'>shop</h1>
          <div className='flex gap-2 flex-col text-center'>
          <a href="">Offers</a>
          <a href="">Gifts card</a>
          <a href="">Uir shop Blog</a>
          </div>
        </div>
        <div className='w-[20%]'>
          <h1 className='my-4 text-[35px] font-medium text-center'>Products</h1>
          <div className='flex gap-2 flex-col text-center'>
          <a href="">all products </a>
          <a href=""> Categories</a>
          <a href="">Popular products</a>
          </div>
        </div>
        <div className='w-[20%]'>
          <h1 className='my-4 text-[35px] font-medium text-center'>About</h1>
          <div className='flex gap-2 flex-col text-center'>
          <a href="">About  us</a>
          <a href="">who’s UirShop</a>
          <a href="">community</a>
          </div>
        </div>
        <div className='w-[20%]'>
          <h1 className='my-4 text-[35px] font-medium text-center'>contact</h1>
          <div className='flex gap-2 flex-col text-center'>
          <a href="">help</a>
          <a href=""> contact info</a>
          <a href="">feed backs</a>
          </div>
        </div>
       
       

      </div>
    </div>
  )
}
