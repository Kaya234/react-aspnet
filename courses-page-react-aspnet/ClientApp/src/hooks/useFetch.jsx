import { useState, useEffect } from "react"

export const useFetch = () => {
    const [data, setData] = useState(null)
    const [isPending, setIsPending] = useState(false)
    const [error, setError] = useState(null)

    useEffect(() => {
        const controller = new AbortController()

        const fetchData = async () => {
            setIsPending(true)

            try {
                const res = await fetch('course', { signal: controller.signal })
                if (!res.ok) {
                    throw new Error(res.statusText)
                }
                const data = await res.json()
                
                setIsPending(false)
                setData(data)
                setError(null)
            }
            catch (err) {
                if ( err.name === "AbortError"){
                    console.log('The fetch was aborted')    
                }
                else {
                    setIsPending(false)
                    setError('Could not fetch data')
                }
            }

        }

        fetchData()

        return () => controller.abort();
        

    }, [])

    return { data, isPending, error }

}