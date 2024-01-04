import React from 'react'

export default function subscripe() {
  return (
    <div className='bg-[#183761] w-full  py-3 px-6 text-center rounded-[50px] mt-3'>
      <h1 className='text-[#FFFFFF]'>Go Yes! Send me exclusive offers, unique gift ideas, and personalized tips for shopping and selling on Makeria</h1>
      <form className='my-5 flex gap-4 w-full'>
        <input type="text" className='w-[100%] py-2 px-4 text-center outline-none rounded-[40px]' placeholder='Email Subscription.' />
        <button className='bg-[#C9CE19] py-2 px-3 text-white rounded-[30px]'>Subscribe</button>
      </form>
    </div>
  )
}
