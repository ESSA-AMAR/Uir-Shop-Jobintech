import logo from '../../assets/logo.png'
import tennu from '../../assets/tennu.png'

export default function Section1() {
  return (
    <div className='bg1 w-full h-[520px] my-3 relative rounded-2xl'>
        <div className='w-full absolute h-full left-0 top-0 bg2 z-20 rounded-2xl'></div>
        <img src={logo} alt=""  className='relative z-50 w-[350px]' />
        <div className='relative z-50 flex justify-between px-10 items-center'>
            <div>
                <h1 className='font-semibold text-[80px] text-white'>E-Shop de L ‘UIR</h1>
                <h2 className='font-semibold text-[40px] text-white w-[70%]'>Le BoutiQue Officielle de L’universite Internationale de Rabat</h2>
            </div>
            <div className='bg3 w-[300px] h-[300px] flex items-center justify-center flex-col rounded-3xl'>
                <img src={tennu} alt="" className='w-[200px]' />
                <div className='text-center text-white '>
                <h1 className='font-semibold text-[32px] text-white'>T-Shirt Polo</h1>
                <h3 className='font-extrabold text-[20px] text-white'>Uir pride Monche courte</h3>
                </div>
            </div>
        </div>
    </div>
  )
}
