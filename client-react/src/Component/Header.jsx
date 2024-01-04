import img1 from '../assets/img1.png'
import img2 from '../assets/img2.jpeg'
import img3 from '../assets/img3.jpeg'
import like from '../assets/like.png'
import shop from '../assets/shop.png'
import search from '../assets/search.png'
import logo from '../assets/logo.png'
import { Link } from 'react-router-dom'
export default function Header() {
  return (
    <div className='w-full flex justify-between items-center py-2 px-4 bg-[#FFFFFF] rounded-2xl shadow-xl'>
    <Link to='/'>
     <img src={logo} alt="" className='w-[140px]' />
    </Link>
    <div className='flex gap-8'>

     <div className='flex  gap-4'>
        <Link to='/product/textile' className='flex flex-col justify-center items-center gap-2'>
            <img src={img2} alt="" className='w-[45px] rounded-full' />
            <h2 className='text-[12px]'>Textile</h2>
        </Link>
        <Link to='/product/Papeterie&Accs' className='flex flex-col justify-center items-center gap-2'>
            <img src={img1} alt="" className='w-[45px] rounded-full' />
            <h2 className='text-[12px]'>Papeterie & Accs</h2>
        </Link>
        <Link to='/product/HighTech' className='flex flex-col justify-center items-center gap-2'>
            <img src={img3} alt="" className='w-[45px] rounded-full' />
            <h2 className='text-[12px]'>High Tech</h2>
        </Link>
     </div>
     <div className='flex items-center gap-4 pb-4'>
        <input type="text" className='w-[550px] py-3 px-5 rounded-full outline-none shadow-md' placeholder='Search Iteam' />
        <div className='bg-[#FDFDFD] w-[50px] h-[50px] rounded-full flex justify-center items-center shadow-md cursor-pointer'>
            <img src={search} alt="" className='w-[20px] cursor-pointer'  />
        </div>
     </div>
    </div>
     <div className='flex gap-7'>
        <div>
            <img src={like} alt="" className='w-[30px] cursor-pointer' />
        </div>
        <div>
        <img src={shop} alt="" className='w-[30px] cursor-pointer' />
        </div>
     </div>
    </div>
  )
}
