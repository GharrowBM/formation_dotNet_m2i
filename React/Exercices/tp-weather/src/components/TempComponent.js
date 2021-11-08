import { Col, Row } from "antd"

export const TempComponent = (props) => {
    return(
        <>
            <Row justify="center">
                <Col>
                    {props.main.temp} °c
                </Col>
            </Row>
            <Row >
                <Col >
                    {props.main.temp_min} °c
                </Col>
                <Col offset={16}>
                    {props.main.temp_max} °c
                </Col>
            </Row>
        </>
    )
}