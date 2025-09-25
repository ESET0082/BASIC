import React from 'react'

export default function ApiPage() {
    const[loading,data,error]=useFetch()
  return (
    <div>
        {
          loading && <>loading... </>
        }
        {
            !loading && error && <>{error.message}</>
        }
    </div>
  )
}
