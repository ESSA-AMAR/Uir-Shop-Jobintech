import logo from '../../assets/logo.png'

export default function Aboutus() {
  return (
    <div className='bg-[#E9E9E73D] w-full flex flex-col shadow-xl my-3 rounded-2xl'>
      <h1 className='text-[#183761] text-[36px] flex items-center mx-auto'>What is <img src={logo} alt="" className='w-[150px]' /> ?</h1>
      <div className='flex justify-between py-7 px-4  text-[#1B4074]'>
        <div className='w-[30%] text-center'>
            <h2 className='my-2 font-bold text-[20px]'>Positive community impact</h2>
            <p className='font-medium'>Uir Shop is a global online store  for student  whos selling unique items. We aim to create positive change for small businesses, people, and the planet through our community-driven approach</p>
        </div>
        <div  className='w-[30%] text-center'>
            <h2 className='my-2 font-bold text-[20px]'>Support independent creators</h2>
            <p className='font-medium'>Uir Shop connects you with makers. Buy extraordinary items directly from people who love what they make.</p>
        </div>
        <div  className='w-[30%] text-center'>
            <h2 className='my-2 font-bold text-[20px]'>Peace of Mind</h2>
            <p className='font-medium'>Uir Shop prioritizes your privacy and support needs, always ensuring peace of mind.</p>
        </div>
      </div>
    </div>
  )
}
